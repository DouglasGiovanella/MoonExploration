# MoonExploration

[Exercicio 001 - Exploração Lunar](https://github.com/leandersonandre/itc-exercicios/blob/master/001-trabalho-exploracao-lunar.md)

Trabalho para a disciplina de Introdução a teória da computação da Univille.

Engenharia de software 4º Ano - 2018

Equipe: Douglas do Amaral Giovanella, Fabiane Machado, Jeferson Machado e José Raul de Quadros

## Execução 

Na pasta builds contém o executável para a plataforma Windows 10 x64 (MoonExploration.exe) 

Na pasta Windows10 x64 executar no prompt de comando: 

> MoonExploration.exe < arquivo_de_entrada.txt > arquivo_de_saida.txt

## Compilação 

- Necessário o dotnet core 2.0 ou superior instalado: https://www.microsoft.com/net/download/thank-you/dotnet-sdk-2.1.104-windows-x64-installer 

Para a geração de build sem a necessidade de instalar o VisualStudio, no root da solução (pasta onde existe o arquivo MoonExploration.sln), abrir o cmd e executar: 

> dotnet build 

Builds para uma plataforma específica (ex. Windows 10 x64): 

> dotnet build -r win10-x64 

Os resultados das builds podem ser encontrados em: 

> ..\MoonExploration\bin\Debug\netcoreapp2.0 

- A lista de plataformas compatíveis para a compilação esta disponível [**aqui**](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog#using-rids). 
