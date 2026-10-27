from urllib import response

from fastapi import FastAPI, APIRouter
from app.services import llm as LLMs


router = APIRouter(prefix="/llm_calls", tags=["llm_calls"])

@router.post("")
def call_llm(prompt: str, llm_type: str) -> dict:
    if llm_type == "openai":
        llm_service = LLMs.OpenAIService()
    elif llm_type == "anthropic":
        llm_service = LLMs.AnthropicService()
    elif llm_type == "openrouter":
        llm_service = LLMs.OpenRouterService()
    elif llm_type == "gemini":
        llm_service = LLMs.GoogleGeminiService()
    else:
        return {"error": "Invalid LLM type. Choose from 'openai', 'anthropic', 'openrouter', or 'gemini'."}

    llm_service.initialize()
    response = llm_service.llm_call(prompt)
    text_output = llm_service.get_response(response)

    return {
        "prompt": prompt,
        "text_output": text_output,
        "full_response": response
    }

app = FastAPI(
    title="API Call LLM",
    description="Unidad VI: Maestria en computo aplicado - Ciberinfraestructura",
)

app.include_router(router)

@app.get("/")
async def root():
    return {"message": "Hello World"}


@app.get("/health", tags=["health"])
def health() -> dict[str, str]:
    return {"status": "ok"}
