Program Name: HetBookStore
Program Purpose: Create a new webapp for Book Store.
Author name: Het Patel
Program date: 2022/11/30

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2022/30/11:
1100: Start the project
1105: Open the ppt slides on the blackboard for review
1110: Create new project into visual studio community 2019
1112: Follow the steps as per the ppt and successfully create a new MVC webapp for bookstore.
1113: Comment down the ssl port 
1115: I create HetsBookStore for my Assignment2.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2022/30/11:
1000: Again start the reading the slides from the resources.
1005: Remove the RequiredConfirmAccount in the startup.cs file
1010: working on wwwroot file as you seen in the ppt.
1012: Now i going to link my git hub account with the project.
1013: Github repository successfully sync with the project.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2022/30/11:
0930: start to changing the layout.cshtml file.
0932: Remove the unnecessory part of thr code in layout.cshtml file.
0935: run the project on browser to check the results.
0936: Program run successfully without error.
0940: start to working on bootstrap file in wwwroot.
0945: open the bootswatch.com site to choose the theme for the assignment
0947: i choose yeti theme for my project.
0948: change the bootstarp file and remove the old one.
0950: change the site.css file with the bootstrap fie.
0955: change the bootstap.min.css to bootstrap.css in views>shared>_layout.cshtml
1000: change the nav class from navbar light to navbar dark and bg-white to bg-primary in layout.cshtml file
1002: line 23 removed as per the instruction in layout.cshtml file.
1005: Now i adding 3rd party tools on the project.
1010: add the necessory links to layout.cshtml file.
1020: Now i working on the navbar to create dropdown menu.

1030: Now i create new 3 projects to the exciting project.
1030: all 3 projects created successfully.
1031: move the DATA folfer into dataaccess folder from original project.
1032: delete the actual original Data folfer from the main project.
1032: start to work on entityframwork packages.
1033: Nuget package install sucessfully.
1131: Error catching after i installed the packages.

-------------------------------------------------------------------------------------------------------------------------------------------------------------

2022/30/11:

1055: Catch some errors in Layout.cshtml file
1056: Resolve the issues from the slides.
1057: Css and Js script added to Layout file.
1107: Delete the Migration folder underneath data folder.
1109: Successfully installed the Identity.EntityFrameworkCore Nuget packages to .dataccess file.
1114: Deleting All 3 Class1.cs files from the .DataAccess, ,Models and .Utility folder.
1125: Modify the Models file.
1130: Added the project refrence to the project.
1131: Rename the models folder to viewmodels.
1131: changing the namespace in errorviewmodels.cs file
1133: Build run successfully.
1135: Start working on Startup.cs file.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

Part 2:
0943: Rebuild the project and it work correctly without eroors.
0944: modify the database name in appsettings.json file
0945: added the migration in .dataaccess through the //add-migration AddDefaultIdentityMigration
0947: migration added successfully.
0948: added category.cs file in models project.
0952: added migation to category file.
1030: catch the errors while adding DB to dataaccess.
1040: migration run successful witghout error.
1041: start the 2.2 for creating repository. 
1100: creating repository folder in dataaccess project
1105: created Irepository.cs inside Irepository folder.
1106: modify the content in Irepository folder
1107: created repository.cs file
1108: adding content in repository.cs file

2022/03/12
0655: Added an 'IRepository' folder inside it.
0657: Added new item of type interface to the folder named 'IRepository'
0659: Modified it, so that it can be used on category class.
0700: Then I fiexed all bugs
0705: Modified the code for constuctors and dependency(DI)
0710 Created two Rpository-
        - CategoryRepository.cs
        - ICategoryRepository.cs
0715: Modified CategoryRepository.cs
0735: Modified ICategoryRepository.cs
0800: Then again fixed some errors
0815: Added new interface int the IRepository folder ISP_Calls.cs
0820: Installed Nuget package for Dapper
0830: Added a new class SP_Call.cs in the Repository
0835: added a connection to the database and added additional using statements
0847: updated implementation of ISP_Call interface.
0855: Added wrapper for Unit of Work
0900: Added new interface IUnitOfWork to the Irepository folder
0904: Modified UnitOfWork.cs
0910: To make it accessible, registered it on Startup.cs
0915: Corrected errors and build it
0917: Some error poped up, but then fixed it while building
0923: Successfully application was builded
0928: Added new MVC Controller - empty inside Areas/Admin
0930: modified it to use the IUnitOfWork from .DataAccess
0935: Added new folder in Areas/View as Controller
0940: added new index view to the folder
0953: Saved and runned it
0954: Successfully runned
1000: In _Layout.cshtml moved 'Category' link to the Content Management dropdown
1002: Reviewed the changes to the navigation
1015: Modified Index.cshtml to add icons in the category section
1017: Deleted it after testing
1020: Added category.js in wwwroot/js folder
1034: In Index.cshtml added @section call to category.js sript and run the project
1040: Then checked it by running
1042: And it was running perfectly fine.
1045: Added IAction result to the controller
1050: Modified upsert view
1052: created partial view for Edit | Back
1055: Added partial named:-
       - _CreateAndBackToListButton
       - _EditAndBackToListButton
1100: Added razor code
1106: Modified upsert.cshtml
1108: There were some errors but I fixed
1115: updated upsert.cshtml
1124: Then I try to solve my error and my error was solved finally..
      I was having problem with my ICategoryRepository.cs
      I have forget to add extension for IRepository<category>
      And I solved it
1130: Finally checked my project.
1131: And it was running successfully
1135: PUSH CODES TO GITHUB........

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

Part 3:
2022/03/12

1140: Now started working on prt 3
1142: first i created new class file CoverType.cs in models folder
1145: then i added a migration file  - 20221122200305_AddCoverTypeToDb.cs
1149: update Dbcontext file as new migration was added
1150: created CoverTypeRepository class
1157: added interface ICoverTypeRepository
1200: create CoverType to unitofwork
1203: then creating CoverType to IUnitofwork
1205: pushed it to database
1209: Added Cover Type to navbar
1210: Added Covertype controller 
1212: Added Cover type index view to use data tables
1214: Added cover type upsert view of creating and updating
1220: Created covertype.js
1223: Now started adding Product
1225: first added new class file product.cs in models
1229: then added a migration file - 20221122230958_AddProductToDb.cs
1230: update Dbcontext file as new migration was added
1235: cerated ProductRepository class
1236: added interface IProductRepository
1240: Then added Product to unitofwork
1242: created Product to IUnitofwork
1245: pushed it to database
1253: Added product to navbar
1255: Added product controller 
1259: Added product index view to use data tables
0100: Added product upsert view of creating and updating
0103: created product.js
0107: created product and images folder
0110: Tiny Cloud link added
0115: Build the project and there were no eroors
0118: Run the project and it run sucessfully
0120: Part 3 complete successfull..........

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

Part 4:
2022/03/12
0200: Build my project and check the errors
0201: No errors were founded in project ready to work on part 4 of project
0208: checking the github repo which you provided

1945: Clone the repo and run the application no error founded
1948: change the code in index.cshtml in customer>view
1949: code not workin showing error
1950: comment down the codes.

2022/06/12
1015: Clone the repo
1017: Build and run the project
1018: Added the category and covertype on application
1020: Product listed and show in product list but not showing on home page
1021: Added codees in index.cshtml in area>customer>view>home
1022: Shows and Model error.
1035: Edit the codes in Homecontroller.cs in Areas>Customer>Controller
1036: run the update-database in Pm console
1037: Run the project and it run successfull
1038: Now i add new product list on web application