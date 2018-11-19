1. **Describe the difference between a view and a partial view.**

A partial view is a "sub-view" that you embed within a main view - something that you might reuse across multiple views, like a sidebar.

2. **Throughout the book you have seen examples of LINQ, in your own words describe what it is used for and how it works.**

It is used to retrieve and modify data.

3. **Give a brief explanation of the ASP.Net routing system.**

ASP.NET routing enables you to use URLs that do not have to map to specific files in a Web site. Because the URL does not have to map to a file, you can use URLs that are descriptive of the user's action and therefore are more easily understood by users.

4. **What is an ASP.NET MVC child action? How would you use a child action?**
A child action is a controller action that you could invoke from the view using the Html.Action helper:
@Html.Action("SomeActionName", "SomeController")
This action will then execute and render its output at the specified location in the view. The difference with a Partial is that a partial only includes the specified markup, there's no other action executing than the main action.

5. **What is a _Layout.cshtml file? How do you use the _Layout.cshtml?**

It is the default layout for a web page. It is generally used as either a baseline layout for a page or the default layout when no specific one has been made.

6. **Describe the following. Include what they are, when you would use them, and how.**

ViewResult represents a class that is used to render a view by using an IView instance that is returned by an IViewEngine object. PartialViewResult is used to render a partial view. ActionResult represents the result of an action method.

7. **What is an Entity and how is it used in this project?**

Entity Framework (EF) is an object-relational mapper that enables .NET developers to work with relational data using domain-specific objects. It eliminates the need for most of the data-access code that developers usually need to write.

8. **When creating a form in ASP.Net what command can you use that will generate the traditional HTML element? What are action attributes and what kind of actions can a form perform?**

HTML.BeginForm or the RenderBeginTag() method is called, which generates the beginning tag of the Web control's specified HTML element. An action filter is an attribute that you can apply to a controller action -- or an entire controller -- that modifies the way in which the action is executed.

9. **What is an ASP.Net session state? How is it being used in this project?**
ASP.NET session state enables you to store and retrieve values for a user as the user navigates ASP.NET pages in a Web application. HTTP is a stateless protocol. This means that a Web server treats each HTTP request for a page as an independent request. The server retains no knowledge of variable values that were used during previous requests. ASP.NET session state identifies requests from the same browser during a limited time window as a session, and provides a way to persist variable values for the duration of that session. By default, ASP.NET session state is enabled for all ASP.NET applications.
