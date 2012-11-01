XSockets Ninject Guide
=============

# An introduction
If you already have service and repository layers you might want to use them from XSockets instead of writing new logic.
Many solutions uses Ninject for IoC and in this example I show howto boost your existing architecture to realtime.

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
- Ran "Scaffold XSocketHandler PersonController" (gives me a new plugin in the XSocketHandler project)
- Ran "Install-Package Ninject" on both my XsocketHandler project and the project starting the XSockets Server.
	In this case the MVC3 project.
- Added references to the Core, Data and Service project into the MVC3 project. Needed in the project starting XSockets.
- Wrote a Ninject Module (see ServiceModule in the XsocketHandler project)
- Wrote my plugin (PersonController) and used my ServiceLayer as always.

- Also added a test page in the root of my MVC3 project (default.htm)


Regards
Uffe, Team Xsockets.NET