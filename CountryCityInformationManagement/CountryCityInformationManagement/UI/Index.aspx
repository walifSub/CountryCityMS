<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CountryCityInformationManagement.UI.index" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <title>City Country Information Management</title>
      <link href="../Content/bootstrap.css" rel="stylesheet" />
      <link href="../Content/sticky-footer-navbar.css" rel="stylesheet" />
      <link href="../Content/style.css" rel="stylesheet" />
      <style>
          *{
	        padding:0px;
	        margin:0px;
	        box-sizing:
        }
        a *,
        a *:before,
        a *:after {
            -webkit-box-sizing: content-box !important;
            -moz-box-sizing: content-box !important;
            box-sizing: content-box !important;
        }
        *:not(.menu-img) { 
	        box-sizing:content-box;
        }
      </style>
  </head>
  <body>
    <header>
    	<h2>Null Point</h2>
    </header>
	<div class="container-fluid">
    	<nav>
        	<div class="menuContainer" id="home">
				<a href="/UI/Index.aspx">
					<img class="menu-img" src="../images/icon_home.png" alt="home"/>
					<p class="text">Home</p>
				</a>
			</div><!--home-->
			<div class="menuContainer" id="service">
				<a href="/UI/CountryEntry.aspx">
					<img class="menu-img" src="../images/customer-service-icon.png" alt="Country Entry"/>
					<p class="text">Country Entry</p>
				</a>
			</div><!--country entry-->
			<div class="menuContainer" id="product">
				<a href="/UI/CityEntry.aspx">
					<img class="menu-img" src="../images/StorageIcon01.png" alt="City Entry"/>
					<p class="text">City Entry</p>
				</a>
			</div><!--city entry-->
			<div class="menuContainer" id="gallery">
				<a href="/UI/CityView.aspx">
					<img class="menu-img" src="../images/icon-gallery.png" alt="City View"/>
					<p class="text">City View</p>
				</a>
			</div><!--city view-->
			<div class="menuContainer" id="contact">
				<a href="/UI/CountryView.aspx">
					<img class="menu-img" src="../images/ICON_contact.png" alt="Country View"/>
					<p class="text">Country View</p>
				</a>
			</div><!--country view-->
            
        </nav>
    </div>
	<footer class="footer">
      <div class="container-fluid">
        <p class="text-muted">Design & Develop By Null Point Team,@All Right Reserved By BITM</p>
      </div>
    </footer>
	<script src="../Scripts/jquery-1.12.3.min.js"></script>
      <script src="../Scripts/bootstrap.min.js"></script>
  </body>
</html>
