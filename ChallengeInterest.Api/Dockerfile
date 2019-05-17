FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ChallengeInterest.Api/ChallengeInterest.Api.csproj ChallengeInterest.Api/
COPY ChallengeInterest.CrossCutting/ChallengeInterest.CrossCutting.csproj ChallengeInterest.CrossCutting/
COPY ChallengeInterest.Business/ChallengeInterest.Business.csproj ChallengeInterest.Business/
COPY Interfaces/ChallengeInterest.IBusiness/ChallengeInterest.IBusiness.csproj Interfaces/ChallengeInterest.IBusiness/
COPY ChallengeInterest.ViewModel/ChallengeInterest.ViewModel.csproj ChallengeInterest.ViewModel/

RUN dotnet restore ChallengeInterest.Api/ChallengeInterest.Api.csproj

COPY . .
WORKDIR /app/ChallengeInterest.Api
RUN dotnet build ChallengeInterest.Api.csproj -c Release -o /app

# Copy everything else and build
RUN dotnet publish ChallengeInterest.Api.csproj -c Release -o /app

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "ChallengeInterest.Api.dll"]