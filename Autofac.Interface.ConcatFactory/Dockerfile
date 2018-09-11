#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 

#FROM microsoft/dotnet-framework:4.7.2-runtime-windowsservercore-1803
#ARG source
#WORKDIR /app
##COPY ${source:-obj/Docker/publish} .
#ENTRYPOINT ["C:\\app\\Autofac.Interface.ConcatFactory.exe"]


FROM microsoft/dotnet:2.2.0-preview1-aspnetcore-runtime AS base

WORKDIR /app



FROM microsoft/dotnet:2.2.100-preview1-sdk AS build

WORKDIR /DineshVisualStudio/Autofac-interceptor/AutofacModule/Autofac.interface.ConcactFactory

COPY /DineshVisualStudio/Autofac-interceptor/AutofacModule/Autofac.interface.Concactfactory/Autofac.interface.concactfactory.csproj project/

WORKDIR /project

RUN dotnet restore

COPY /DineshVisualStudio/Autofac-interceptor/AutofacModule/Autofac.interface.Concactfactory .

RUN dotnet build -c Release -o F:/app



FROM build AS publish

RUN dotnet publish -c Release -o /app



FROM base AS final

WORKDIR /app

COPY --from=publish /app .

ENTRYPOINT ["Autofac.Interface.ConcatFactory.exe"]
#