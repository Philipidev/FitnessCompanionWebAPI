download docker desktop + WSL 2 (kernel linux)

```bat
docker -v
```
para verificar se foi instalado correntamente

```bat
docker run -e"ACCEPT_EULA=Y" -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=BHkQ7Bzy" -p 14333:1433 --name fitnessCompDck -h fitnessCompDck -d mcr.microsoft.com/mssql/server:2019-latest
```

criar container fitnessCompDck com linux e o mssql no container fitnessCompDck

```bat
docker restart fitnessCompDck
```

```bat
docker exec -it fitnessCompDck /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P BHkQ7Bzy
```
