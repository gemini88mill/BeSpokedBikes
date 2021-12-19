Bespoked Bikes Coding review Readme. 

### Installation / Run Instructions

#### Libraries 

- .Net5 
- Vue.js 2.6.14
- axios.js
- bootstrap 5.0.1
Note: When running in Linux it is nessesary to add a utilization feature in order to get
localhost to use HTTPS, please visit
 https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-6.0&tabs=visual-studio#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos

for more details. 

## Runtime instructions

### Backend
Solution should be able to be run without any problems with IIS express. However please insure .net5
SDK and runtime is installed on your machine. 

### Front-end
The dist folder is packaged along with the source for easy running, however, the program relies on 
vue.js framework to run properly. Running in development will require the frameworks above to be
installed.  

https://vuejs.org/v2/guide/installation.html <-- for more info.   

Please verify that the localhost configuration, is set as the localhost configuration on the
back end. By Default the port is set to 5001, if IIS decides to give you another port number, or that
port is being used, please change the port in the main.js file line 8.  

8 	Vue.prototype.$hostname = "https://localhost:5001/"

BespokeBikesAPI runs first 
UI runs second. 


