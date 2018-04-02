# aspnetcore-app1
Sample app as Asp.Net Core 2.0 entry point (with dockerfile to run the app within a docker container)

## Usage instructions
Navigate to app folder, for example:
```
> cd aspnetcore-app1/
```
And just type dotnet run command, like this:
```
> dotnet run
```

## Running docker container
First build the app image running the command below (from the app folder):
```
> docker build -t aspnetapp .
```
> **Note:** this is going to build an image named **aspnetapp**

When finished building the image, run it!
```
> docker run -d -p 8080:80 --name myapp aspnetapp
```
Where: 
- **myapp** is the name of the container
- **aspnetapp** is the name of the image you created earlier
