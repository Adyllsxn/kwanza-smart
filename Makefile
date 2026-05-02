.PHONY: run
run:
	@echo "🚀 Rodando KwanzaSmart Aspire AppHost..."
	dotnet run --project orchestration/aspire/KwanzaSmart.AppHost/KwanzaSmart.AppHost.csproj

.PHONY: build
build:
	dotnet build

.PHONY: restore
restore:
	dotnet restore

.PHONY: clean
clean:
	dotnet clean

.PHONY: test
test:
	dotnet test