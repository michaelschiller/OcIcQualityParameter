### Demo of non-working quality parameter with OrchardCore 1.5.0 and media profiles

Using a media profile the quality parameter has no effect.  

Simply start debugging the project. Two images will be displayed. First uses resize_url with a media profile, the second uses a manually typed url where quality parameter has been moved behind the format parameter. 

The problem might be fixed by changing the ordering of parameters in `OrchardCore.Media.Services.MediaProfileService.GetMediaProfileCommands(string name)`.  

### Admin credentials
User: `admin`  
Password: `Password1?`  
 
