from typing import Literal
from pydantic import BaseModel
from http.client import HTTPException
from fastapi import FastAPI, APIRouter

from app.services import llm as LLMs


router = APIRouter(prefix="/llm_calls", tags=["llm_calls"])

class LLMRequest(BaseModel):
    prompt: str
    llm_type: Literal["openai", "anthropic", "openrouter", "gemini"]


@router.post("")
def call_llm(request: LLMRequest) -> dict:
    prompt = request.prompt
    llm_type = request.llm_type

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
    try:
        response = llm_service.llm_call(prompt)
        text_output = llm_service.get_response(response)
    except Exception as e:
        raise HTTPException(status_code=502, detail=f"Error del proveedor LLM: {e}")

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
