import os
from abc import ABC, abstractmethod
from dotenv import load_dotenv
from google import genai
from openai import OpenAI
from anthropic import Anthropic
from openrouter import OpenRouter


load_dotenv()


class LLMService(ABC):
    def __init__(self):
        self.api_key = None
        self.client = None

    @abstractmethod
    def initialize(self):
        raise NotImplementedError("Subclasses must implement the initialize method.")

    @abstractmethod
    def llm_call(self, prompt: str) -> str:
        raise NotImplementedError("Subclasses must implement the llm_call method.")

    @abstractmethod
    def get_response(self) -> str:
        raise NotImplementedError("Subclasses must implement the get_response method.") 


class GoogleGeminiService(LLMService):
    def initialize(self):
        self.api_key = os.getenv("GEMINI_API_KEY")
        if not self.api_key:
            raise ValueError("GEMINI_API_KEY is not set in the environment variables.")
        self.client = genai.Client(api_key=self.api_key)

    def llm_call(self, prompt: str) -> str:
        if not self.client:
            raise ValueError("Client is not initialized. Call initialize() first.")

        interaction = self.client.interactions.create(
            model="gemini-3.8-live",
            input=prompt
        )

        return interaction

    def get_response(self, interaction) -> str:
        if not interaction:
            raise ValueError("Interaction is empty. Ensure llm_call() was successful.")

        return interaction.output_text


class OpenAIService(LLMService):
    def initialize(self):
        self.api_key = os.getenv("OPENAI_API_KEY")
        if not self.api_key:
            raise ValueError("OPENAI_API_KEY is not set in the environment variables.")
        self.client = OpenAI(api_key=self.api_key)

    def llm_call(self, prompt: str) -> str:
        if not self.client:
            raise ValueError("Client is not initialized. Call initialize() first.")

        response = self.client.responses.create(
            model="gpt-4o-mini",
            input=prompt
        )

        return response

    def get_response(self, response) -> str:
        if not response:
            raise ValueError("Response is empty. Ensure llm_call() was successful.")

        return response.output_text


class AnthropicService(LLMService):
    def initialize(self):
        self.api_key = os.getenv("ANTHROPIC_API_KEY")
        if not self.api_key:
            raise ValueError("ANTHROPIC_API_KEY is not set in the environment variables.")
        self.client = Anthropic(api_key=self.api_key)

    def llm_call(self, prompt: str) -> str:
        if not self.client:
            raise ValueError("Client is not initialized. Call initialize() first.")

        message  = self.client.messages.create(
            model="claude-haiku-4-5",
            max_tokens=1000,
            messages=[
                {
                    "role": "user",
                    "content": prompt,
                }
            ],
        )

        return message

    def get_response(self, message) -> str:
        content = ""
        for block in message.content:
            if block.type == "text":
                content += block.text
        return content


class OpenRouterService(LLMService):
    def initialize(self):
        self.api_key = os.getenv("OPEN_ROUTER_API_KEY")
        if not self.api_key:
            raise ValueError("OPEN_ROUTER_API_KEY is not set in the environment variables.")
        self.client = OpenRouter(api_key=self.api_key)

    def llm_call(self, prompt: str) -> str:
        if not self.client:
            raise ValueError("Client is not initialized. Call initialize() first.")

        response = self.client.chat.send(
            model="openai/gpt-4o-mini",
            messages=[
                {"role": "user", "content": prompt}
            ],
        )

        return response

    def get_response(self, response) -> str:
        if not response:
            raise ValueError("Response is empty. Ensure llm_call() was successful.")

        return response.choices[0].message.content 
