# SETUP

1. install image 
```bash
docker pull mcr.microsoft.com/azure-sql-edge
```

2. init database
```bash
docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=reallyStrongPwd123" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=sql mcr.microsoft.com/azure-sql-edge
```

3. check that its running
```bash
docker ls
```

