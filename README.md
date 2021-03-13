# _HairSalon_

#### _An application where a user can keep track of stylists and clients_

#### By _**Nick Lindau**_

## Technologies Used

* _.NET5.0_
* _C#_
* _Visual Studio Code_
* _ASP NET Core MVC_
* _MySql_
* _MySql Workbench_
* _Entity Framework_
* _Bootstrap_
* _CSS_
* _ASP.NET Razor_

## Description

_This application will allow a user to add a client to list of specialized stylists they can create and display information about the stylists and clients. This application will use a MySql database to hold onto client information for the user_

## Setup/Installation Requirements

* _Find the respository at (https://github.com/NickyLind/HairSalon)_
* _Select the green 'Code' button above the repository and copy the HHTPS link_
* _In your terminal, find the directory you want to place the HairSalon directory in_
* _In your terminal, use the git command `$git clone https://github.com/NickyLind/HairSalon`_
* _Open in Visual Studio Code or another editor_
* _In order to run this project you are going to need to have access to a MySql server and the MySql Workbench Gui_
* _You can find the MySql Community server page here (https://dev.mysql.com/downloads/file/?id=484914) and after you download you simply follow along with the installer_
* _You can find the MySql Workbench download file at (https://dev.mysql.com/downloads/file/?id=484391) and follow along with the installer_
* _For more in-depth instructions on setting up the MySql Community server and MySql Workbench for you specific OS visit (https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)_
* _Open MySql Workbench and select the Local instance 3306 server and enter the password you set up at installation_
* _In the MySql Workbench, in the Navigator/Administration window, select Data Import/Restore_
* _In Import Options select Import from Self-Contained File, and navigate to the `nick_lindau.sql` file in the top level of the HairSalon.Solutions directory_
* _Under Default Schema to be Imported To, select the New button, and make sure to name the schema nick\_lindau and click Ok._
* _Click Start Import, then return to the Navigator > Schemas tab and right click and select Refresh All and the new database should appear_
* _Now that the database is set up you will need to create a file called `appsettings.json` in the top level of the HairSalon directory and paste the following code:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=nick_lindau;uid=[YourUserIdHere];pwd=[YourPasswordHere];"
  }
}
```
* _Make sure you replace the [YourUserIdHere] & [YourPasswordHere] with the username and password you created when you installed MySql Workbench_
* _You will need to restore the dependencies and project specific tools by running the `$dotnet restore` command in the HairSalon directory, as well as build the project using the `$dotnet build` command in the same directory_
* _To run the program, you will need to navigate to the HairSalon directory and run the command `$dotnet run`_
* _If everything is working correctly a server should open up in localport:5000._
* _You can type Http://localport:5000 into your browser search bar to acess the site_

## Known Bugs

* _Css is still being worked out to have a better looking flow between pages_


## License

_[MIT](https://choosealicense.com/licenses/mit/)_
 _Copyright (c) Nick Lindau 03/12/2021_

## Contact Information

_Nick Lindau @ <nicholaithegreat@gmail.com>_
