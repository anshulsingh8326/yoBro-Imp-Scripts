By Anshul Singh :

# You Need Two Scripts: **ApplicationChrome.cs** and **ScreenSize.cs**

1. **Create a Script Called `ApplicationChrome.cs`**  
   Add the necessary code to this script.  

2. **Call the `ApplicationChrome.cs` Script**  
   Use the desired function from `ApplicationChrome.cs` in another script named **`ScreenSize.cs`**.  

3.   - For details on function calling, check the Heading1 at the bottom.

---

### Code Author Link: [Here](https://gist.github.com/blevok/3dc5fec55a96b6f60ca24b49b4fcf98a)
```
<span style="color: #b96ad9;">\===========================================================================================================================================</span>

**Heading1 :**

/*if (HideNavStatus == 0)  
{  
    // Set the status/navigation background color (set to 0xff000000 to disable)  
    ApplicationChrome.statusBarColor = ApplicationChrome.navigationBarColor = 0xff000000;

&nbsp;   // Makes the status bar and navigation bar visible over the content (different content resize method)  
    ApplicationChrome.statusBarState = ApplicationChrome.navigationBarState = ApplicationChrome.States.VisibleOverContent;

&nbsp;   //// Toggles the dimmed out state (where status/navigation content is darker)  
    [//ApplicationChrome.dimmed](//ApplicationChrome.dimmed) = !ApplicationChrome.dimmed;

&nbsp;   //// Makes the status bar and navigation bar visible (default)  
    [//ApplicationChrome.statusBarState](//ApplicationChrome.statusBarState) = ApplicationChrome.navigationBarState = ApplicationChrome.States.Visible;

&nbsp;   //// Makes the status bar and navigation bar visible over the content, but a bit transparent  
    [//ApplicationChrome.statusBarState](//ApplicationChrome.statusBarState) = ApplicationChrome.navigationBarState = ApplicationChrome.States.TranslucentOverContent;  
}  
else  
{  
    // Makes the status bar and navigation bar invisible (animated)  
    ApplicationChrome.statusBarState = ApplicationChrome.navigationBarState = ApplicationChrome.States.Hidden;  
}  
*/