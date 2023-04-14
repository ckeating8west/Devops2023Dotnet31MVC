echo "Building"
dotnet build --no-restore --configuration Release

echo "Deploying site"
cd bin\Release\netcoreapp3.1\
scp *.* ptuser@20.82.181.106:~/www/dotnet06/
cd ..\..\..
scp -r wwwroot ptuser@20.82.181.106:~/www/dotnet06/

echo "Restarting Service"
ssh ptuser@20.82.181.106 sudo systemctl restart dotnet06.service