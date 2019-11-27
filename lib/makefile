APP_NAME="analytics-py-h2o-3.20.0.6"
DOCKER_REPO_LOCAL="local"
DOCKER_REPO="vfie"
VERSION="0.1"

all: build tag

test: ## Run tests
	dotnet test

clean: ## Removes saved container
	dotnet clean

publish: ## Publish build output to Unity
	dotnet publish -o ../1st-try/Assets/Library

rm: ## Removes output from Unity
	rm -r ../1st-try/Assets/Library/

.PHONY: help

help:
	@grep -E '^[a-zA-Z_-]+:.*?## .*$$' $(MAKEFILE_LIST) | sort | awk 'BEGIN {FS = ":.*?## "}; {printf "\033[36m%-30s\033[0m %s\n", $$1, $$2}'

.DEFAULT_GOAL := help
