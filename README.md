XSockets Ninject Guide
=============

# An introduction
If you already have service and repository layers you might want to use them from XSockets instead of writing new logic.
Many solutions uses Ninject for IoC and in this example I show howto boost your existing architecture to realtime.

The example architecture is based on EntityFramework CodeFirst together with UnitOfWork and RepositoryPattern

# For who´?
Anyone interested in realtime development with knowledge of C# and JavaScript

# A short summary of what I did.
- Create a new MVC3 project
- Run "Install-Package CodePlanner" (gives me a nice architecture with UoW and Repository Pattern)
- Added a domainmodel in the Core project. Just added a Person class
- Ran "Scaffold CodePlanner.ScaffoldBackend" (will create all interfaces and classes for my domainmodel)
__________________________________________
- Note: Here is where you probably come in... You have your architecture, I built my own above.
- Ran "Install-Package XSockets"
- Ran "Scaffold XSocketController XControllers\PeopleController" (gives me a new plugin in the webproject under XControllers)
- Ran "Install-Package Ninject" on my MVC project.
- Added references to the Core, Data and Service project into the MVC3 project.
- Wrote a Ninject Module (see ServiceModule under XControllers in MVC project)
- Wrote my plugin (PersonController) and used my ServiceLayer as always.

- Also added a test page in the root of my MVC3 project (default.htm)


Regards
Uffe, Team Xsockets.NET