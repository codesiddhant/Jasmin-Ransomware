[![Siddhantgour][Instagram-shield]][Instagram-url]  [![LinkedIn][linkedin-shield]][linkedin-url] 
[![Siddhantgour][Twitter-shield]][Twitter-url] [![Youtube][Youtube-shield]][Youtube-url] [![Telegram][Telegram-shield]][Telegram-url] [![Quora][Quora-shield]][Quora-url]  [![Facebook][Facebook-shield]][Facebook-url] 
<p align="center">
  <img alt="jasmin ransomware" src="https://github.com/codesiddhant/jasmin-ransomware/blob/master/Images/logo.jpg" width="150"/>
</p>
<h1 align="center">Jasmin The Ransomware</h1>

  <p align="center">
    A Powerful Ransomware Tool for Security Testing Used by ReadTeams
    <br />
    <a href="https://www.youtube.com/watch?v=9YcM18YQ9MA">Video Tutorial</a>
    ·
    <a href="https://github.com/codesiddhant/jasmin-ransomware/issues">Report Bug</a>
    ·
    <a href="https://instagram.com/siddhantgour">Request Free Keygen</a>
  </p>
</p>

<details open="open">
  <summary>Table of Contents</summary>
  <ol>
   <li><a href="#disclaimer-%EF%B8%8F-">Disclaimer ⚠️</a></li>
    <li>
      <a href="#about-the-project-">About The Project</a>
      <ul>
        <li><a href="#built-with-">Built With</a></li>
        <li><a href="#work-flow-">Work Flow</a></li>
      </ul>
    </li>
    <li>
      <a href="#setup-and-running-%EF%B8%8F">Setup & Running</a>
      <ul>
        <li><a href="#prerequisites-">Prerequisites</a></li>
        <li><a href="#Clone-This-Repo">Installation</a></li>
        <li><a href="#webserver--database">Webserver</a></li>
        <li><a href="#Generating-Payload-">Encryption Payload</a></li>
        <li><a href="#Decryption-Process-">Decryption Tool</a></li>
      </ul>
    </li>
    <li><a href="#license-">License</a></li>
    <li><a href="#contact-">Contact</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About The Project 💡
<p align="center">
  <img alt="jasmin ransomware" src="https://github.com/codesiddhant/jasmin-ransomware/blob/master/Images/jasmin-banner.gif" width="850"/>
</p>

<span style="color:red"> <h2>Please First read the <a href="#disclaimer-%EF%B8%8F-">DISCLAIMER</a> ⚠️⚠️</h2> </span>
</div>
</div>

Jasmin is a different kind of ransomware worm by which many of your documents, photos, videos, database and other important files are no longer accessible because they have been encrypted and it becomes impossible for users to access their files without decryption tool and valid key.
This Tool is Developed to help Red teams and ethical hackers simulating a real ransomware attack. <br>
There is really no shortcut for something like this. It's not enough to just know what files could be encrypted, and you certainly don't need a tool to tell you that. <br>
This is a ransomware simulator that can safely encrypt some files on your computer, to let you know if your defenses are actually working. Jasmin Ransomware is developed by security researcher siddhant gour. <br>


 Why use Jasmin for security testing ?: ?:
* Jasmin Ransomware is developed using C#(.Net Framework) which makes it lighter in weight and easier to embed.
* You Can Simulate a real ransomware attack and bypass any kind of system securities .
* Powerful | Strong Encryption | Centralized Database on Server| Can Bypass Anti Virus.

## Built With 🧱
	
[![Payload][c#-shield]][c#-url]  [![Dashboard][bootstrap-shield]][bootstrap-url] 
[![Server][php-shield]][php-url] [![Database][mysql-shield]][mysql-url] 

## Work Flow 🧾
<p align="center">
  <img alt="jasmin ransomware" src="https://github.com/codesiddhant/jasmin-ransomware/blob/master/Images/workflow.png" />
</p>

## Prerequisites 🧰

* **Visual Studio 2019 or later** </br>

* **Xampp Server (Windows) or LAMP Server(Linux)** </br>

* **Ngrok for port forwarding** </br>

## SETUP AND RUNNING 🖥️

* ### Clone This Repo
   ```sh
   git clone https://github.com/codesiddhant/jasmin-ransomware.git
   ```
* ### Webserver & Database 
   
    * **Copy the all the files in webpanel directory to htdocs or (/var/www/html)**  
	
	* **Open Mysql Shell** 
	
	 <p align="center">
    <img alt="jasmin ransomware" src="https://github.com/codesiddhant/jasmin-ransomware/blob/master/Images/xampp.jpg" />
    </p>
	
	* **Login as Root user** 
	```sh
     mysql -h localhost -u root
   ```
    * **Create new database & assign user**
	
	```sh
     CREATE DATABASE jasmin_db;
	 CREATE USER 'jasminadmin'@'localhost' IDENTIFIED BY '123456';
	 GRANT ALL PRIVILEGES ON jasmin_db.* TO 'jasminadmin'@'localhost';
	 Exit
   ```
	
	* **Importing jasmin_db.sql file from database directory** 
	
	```sh
      mysql -u jasminadmin -p123456 jasmin_db < htdocs/database/jasmin_db.sql
    ```
	* **Loggin Dashboard**
     
	 Open Google Chrome and visit http://localhost/ <br>
	 Use default credentials
	```sh
     Username    : siddhant
	 Access Code : 123456
    ```
	
* ### Generating Payload 💣
         
    Note: You should have installed visual studio 2019 or later in your machine		 
	
	* **Use ngrok server for port forwarding (Wan Attack)**
	 
	```sh
     ngrok  http localhost:80
    ```
	
	* **Copy Forwarding Address** 
	
	<p align="center">
    <img alt="siddhantgour" src="./Images/ngrok.PNG">
    </p>
	
	* **Configure variables** <br>
         * =>   Inside **"Jasmin Encrypter"** directory open "Jasmin Encryptor.sln" file <br>
         * =>   Go to line number 34 & 35 <br>
	     * =>   Set Ngrok host address for **"hostaddr"** & **"AlertMsgLink"** Variable <br>
	
    <p align="center">
    <img alt="jasmin ransomware" src="./Images/variable.gif">
    </p>
	
	* **Building .Exe File** <br>
	     * =>   Go to top nav bar & click to build => Clean Solution  <br>
         * =>   Again click to build => Clean Jasmin Encryptor <br>
	     * =>   Once Again click to build button => Rebuild Jasmin Encryptor <br>
		 * =>   Go to **"Jasmin Encryptor\bin\Release"** directory !! Congrats Payload is ready <br>
		 
* ### Next Steps 😤	
    * **Sending File to Victim's Pc** <br>
	     * Replace the email address inside "webpanel/alertmsg.zip/index.html" <br>
	     * Now, Send this Payload file to your victims through emails or any socail other engineering technique you want <br>
		 * When Ever our victim click on that payload file it will encrypt all important files and send the decryption key to our web dashboard <br>
		 * For Custom alert message to your victims, edit the HTML file inside "webpanel/alertmsg.zip" <br>
		 
* ### Decryption Process 🔑			  
    * **Decrypting Victims File** <br>
	     * =>   open **"Jasmin decryptor\Jasmin decryptor.sln"** & build the .exe file <br>
         * =>   get the **SystemId** from your victims through emails  <br>
	     * =>   download the Decryption key from web-dashboard for that **SystemId** <br>
		 * =>   reply your victims with Decryption Tool and Passsword File  <br>
		 
<!-- LICENSE -->
## DISCLAIMER ⚠️ 🚨
 * Codesiddhant is a Github Page related to Computer Security  and not a site that promotes hacking / cracking / software piracy. <br>
 * Do not attempt to violate the law with anything contained here. If you planned to use the tool for illegal purpose, then please leave this site immediately! We will not be responsible for your any illegal actions. Neither administration of this tool, the developer of this application, or anyone else affiliated in any way, is going to accept responsibility for your actions. <br>
 * You shall not misuse this tool to harm someone’s computer. However, you may try out these hacks on your own computer at your own risk. Simulating Ransomware attack (without permission) on computers that you do not own is illegal. <br>
 * We believe only in White Hat Hacking. On the other hand, we condemn Black Hat Hacking. <br>
 * **A ransomware attack is considered to be illegal activity aside from capturing your data in the computer, it will demand you to pay a ransom fee. Encrypting someone’s data without their written permission is a punishable offense** <br> 
 

## License 📝

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact 📞
Wanna Jasmin Pro with custom features ? Dm me <br>
 <br>
[![Siddhantgour][Instagram-shield]][Instagram-url]  [![LinkedIn][linkedin-shield]][linkedin-url] 
[![Siddhantgour][Twitter-shield]][Twitter-url] [![Youtube][Youtube-shield]][Youtube-url] [![Telegram][Telegram-shield]][Telegram-url] [![Quora][Quora-shield]][Quora-url]  [![Facebook][Facebook-shield]][Facebook-url] 
		 
		   
  
<!-- https://github.com/Ileriayo/markdown-badges-->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/siddhantgour

[Instagram-shield]: https://img.shields.io/badge/siddhantgour%20-%23E4405F.svg?&style=for-the-badge&logo=Instagram&logoColor=white
[Instagram-url]: https://instagram.com/siddhantgour
[Twitter-shield]: https://img.shields.io/badge/Twitter%20-%231DA1F2.svg?&style=for-the-badge&logo=Twitter&logoColor=white
[Twitter-url]: https://twitter.com/siddhantgour
[Youtube-shield]: https://img.shields.io/badge/Youtube%20-%23FF0000.svg?&style=for-the-badge&logo=Youtube&logoColor=white
[Youtube-url]: https://youtube.com/cyberstair
[Telegram-shield]: https://img.shields.io/badge/Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white
[Telegram-url]: https://t.me/siddhantgour
[Facebook-shield]: https://img.shields.io/badge/Facebook%20-%231877F2.svg?&style=for-the-badge&logo=Facebook&logoColor=white
[Facebook-url]: https://facebook.com/siddhantgour01
[Stackoverflow-shield]: https://img.shields.io/badge/-Stackoverflow-FE7A16?style=for-the-badge&logo=stack-overflow&logoColor=white
[Stackoverflow-url]: https://stackoverflow.com/users/story/12037921
[Quora-shield]: https://img.shields.io/badge/Quora%20-%23B92B27.svg?&style=for-the-badge&logo=Quora&logoColor=white
[Quora-url]: https://www.quora.com/profile/Siddhant-Gour-1


[c#-shield]: https://img.shields.io/badge/Payload%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white
[c#-url]: https://dotnet.microsoft.com/
[bootstrap-shield]: https://img.shields.io/badge/Dashboard%20-%23563D7C.svg?&style=for-the-badge&logo=bootstrap&logoColor=white
[bootstrap-url]: https://getbootstrap.com/
[php-shield]: https://img.shields.io/badge/Server-%23777BB4.svg?&style=for-the-badge&logo=php&logoColor=white
[php-url]: https://www.php.net/
[mysql-shield]: https://img.shields.io/badge/Database-%2300f.svg?&style=for-the-badge&logo=mysql&logoColor=white
[mysql-url]: https://www.mysql.com/
