# _Gallery Gram_

#### By: 

### _**Lucas Mollerstuen**_
### _**Brandon Fenk**_
### _**David Gamble**_
### _**Robert Bryan**_

![crew](https://user-images.githubusercontent.com/115112679/214910042-56c07865-d99b-4366-9658-b157b0e9304e.jpeg)

## Technologies Used

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Postman](postman.com)
* [CSS Tips and Tricks](https://css-tricks.com/)
* [HTML](https://html.com/)


### Description
This is a Gallery application that utilizes uploading of pictures, liking pictures, and purchasing prints of the pictures that you enjoy. Utilizing a shopping cart API, authentication and authorization, and databases.  Each user will create their own profile and gain access to their own profile showing photos that they have uploaded as well as the images that they have 'liked'.

### EXAMPLE IMAGES:

#### User Account Page
![Screen Shot 2023-01-26 at 9 53 20 AM](https://user-images.githubusercontent.com/115112679/214912415-f52ec00d-0fdb-4f15-b4b1-ea1e76474ef5.png)

#### Image Upload Page
![Screen Shot 2023-01-26 at 9 54 15 AM](https://user-images.githubusercontent.com/115112679/214912716-f6e5b836-0238-4fb2-b6be-616c14b0d8eb.png)

#### Gallery Page
![Screen Shot 2023-01-26 at 9 54 36 AM](https://user-images.githubusercontent.com/115112679/214912833-dba136a6-d765-4446-bed9-470675105f96.png)

#### Print Order Page
![Screen Shot 2023-01-26 at 9 55 03 AM](https://user-images.githubusercontent.com/115112679/214913007-cfa82c8f-93bc-4220-8fc6-dc6b05157eb0.png)

## Setup/Installation Requirements
* _Clone the repository to your desktop from:_
``` 
https://github.com/robbryandev/GalleryGram.git
```
* _Create appsettings.json file in GalleryGramApp folder and paste the following in the file_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[database_name];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _Create EnvironmentVariables.cs file in GalleryGramApp folder and paste the following in the file_
```
namespace GalleryGram.Keys
{
  public static class EnvironmentVariables
  {
    public static string ApiKey = "[SANDBOX API KEY]";
  }
}
```
* _run dotnet commands below in _GalleryGramApp_
```
dotnet restore
```
```
dotnet ef database update
```
```
dotnet watch run
```
------------------------------

## Known Bugs
* None known. If you find a bug in our code please leave a message at [mollerstuen.works@gmail.com]

### Research done using:
* [CodePen](https://codepen.io/)
* [FFFuel.io](https://fffuel.co/ffflux/)
* [Prodigi Api](https://www.prodigi.com/)
* [Microsoft Learn](https://learn.microsoft.com/en-us/)

## License

_Copyright (c) 2023 Lucas Mollerstuen, Brandon Fenk, Robert Bryan, David Gamble_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._



## Thank you for your time!

![My Remote Image](https://user-images.githubusercontent.com/115112679/213828887-8b49e9ab-f7fd-4d7a-a7fa-9fe63fabc363.png)
