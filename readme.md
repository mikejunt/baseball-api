### Baseball API

This is a RESTful web API built in .NET Core 3.1 for my Baseball Application (https://github.com/mikejunt/mlbAngular).   It utilizes Microsoft Entity Framework to handle data requests from the application and handle queries against the PostgreSQL database holding the project data.   

This was my first project in C# using the .NET framework.   As the database already existed from the node.js version of my application, I was able to use Entity Framework's database-first construction to create the database context and controllers from the existing database.   

This is a relatively simple API because it is exclusively GET requests.   The application it serves does not modify the data (which is static, historical statistical information).  For this reason, I disabled authentication on the API paths after configuring it, as there was no need to introduce the additional service delay to have the application wait for its' authentication token before requesting the data. However, the authentication service is installed and configured.  It is just not implemented on any existing routes.

If this were to be utilized for actual, updating information (such as during a new baseball season), I would create additional, authenticated paths for the scheduled tasks pulling and updating daily data utilizing the in-place authentication configuration.

While the information in this API is publically accessible, I have chosen not to provide documentation.  The data contained within the database is originally the property of Major League Baseball Advanced Media, LP and used with their permission.   