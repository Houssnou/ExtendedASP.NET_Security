# ExtendedASP.NET_Security
This is a playground for extending(or customizing) ASP.NET Identity User Model.

I came accross this issue so I decided to set my playground box to customize the User Model scaffolded by .Net Identity.

For a new project the customization is done in 04 steps:
1. Update the **IdentityModel.cs** file in the **Models** Repo
   * add the new properties to the **ApplicationUser** method 
   * Exple: `public string FirstName { get; set; }`
            `public string LastName { get; set; }`
2. Update the **AccountViewModel.cs** file within the same repo to add the new properties. Feel Free to add some decorator for solid data validation.
3. Update the **Register** Action in the **AccountController.cs** file in the **Controllers** repo. Add the new properties to the **ApplciationUser** Method
    ```

        var user = new ApplicationUser {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

    ```
4. Finally update the view (register view) to add the corresponding fields (matching properties).


           
