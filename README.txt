
Creating Web Services with Database SQL Server Management Studio

1.) Start Page - Microsoft Visual Studio > File > New > Project > WCF Service Library
2.) Delete the  generated class
3.) For more information about web.config and app.config please open this filename.
    *web(config).xml and *app(config).xml

For your guide making a web services please open the project that you see in this folder.

Note: Make sure the Target framework is .NET Framework 4
Right Click the Project > Properties

Create a Link between SQL Server Management Studio and the Project

1.) Right Click the Project > Add > New Item > Select Linq to Sql Classes
2.) In Server Explorer, Click Connect to Database. Supply the data needed after that
Test Connection. If it is already connected then click OK, If not try again.
3) Click the plus sign beside Database Name > Tables > Drag the Table in the center screen. Click yes to retain your database password in the config.



Creating Website to connect the Project and the IIS

1.)Right click the solution > Add > New website
2.)Check the location of the file. Project must be save in same folder with the Service Project you made.
3.)Right click the Website Project > Add ASP.Net Folder > Bin
4.)Right click the Website Project > Add ASP.Net Folder > App_Data
5.)Right click the Website Project > Add New Item > Then type "Service.svc" in the name.
6.)Right click the Bin > Add Reference > In project you see the service project then click add.
7.)In Service.svc change the code with this 

<%@ ServiceHost Language="C#" Debug="true" Service="WebServiceExample.Service" Factory="Microsoft.ServiceModel.Web.WebServiceHost2Factory"%>

Note: Service must be ProjectName.ServiceClass same service name in app.config 


Connect the Website Project and the IIS Setup.

1.) If you dont have Internet Information Services(IIS). Please look at in the GitHub there is a Repository Called "Creating IIS" that's will help you Creating IIS.
2.)If you have, Go to Start > Run or simply Press windows + r for shortcut keys. In Run type "inetmgr" then OK.
3.)In IIS click plus sign beside computer name > Again click plus sign beside Sites 
4.)Right click the default web site > Add application 
5.)Fill in the alias text box what you want, In Physical Path click the browse then find the Website Project that you make and Select the Folder of the Website Project.
6.)Then now, we try to access the service.. http://localhost/examplewebservice/service.svc/help 


