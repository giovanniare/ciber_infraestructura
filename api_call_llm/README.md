# GENERACION DE UNA UTILERIA API CALL A LLM

## Configuracion

1. Copia `.env.example` a `.env` y completa tus valores:

```
OPENAI_API_KEY=...
ANTHROPIC_API_KEY=...
GEMINI_API_KEY=...
OPEN_ROUTER_API_KEY=...
APP_ENV=development
LOG_LEVEL=info
```

2. Instala dependencias:

```bash
uv sync
```

## Ejecutar el servicio

```bash
uv run fastapi dev
```

## API DOC:
```
http://localhost:8000/docs
```

## DOCS
- https://openrouter.ai/docs/client-sdks/overview
- https://platform.claude.com/docs/en/get-started
- https://developers.openai.com/api/docs/quickstart?language=python
- https://aistudio.google.com/docs/get-started?_gl=1*e3b3af*_up*MQ..&gclid=CjwKCAjw9PvWBhAxEiwAddzYyUBTH5el9Z95Jy0NYYYW8XR6Ksz-1IfSNO61utvOFQwvs3COE5I2ZRoC3-UQAvD_BwE&gbraid=0AAAAACn9t67Vzmhspdpff73FD_ZpaJ-On&codelanguage=python
- https://fastapi.tiangolo.com/tutorial/