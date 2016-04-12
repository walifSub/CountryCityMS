﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryCityInformationManagement.UI.CityEntry" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <title>City Country Information Management | City Entry</title>
      <link href="../Content/bootstrap.css" rel="stylesheet" />
      <link href="../Content/sticky-footer-navbar.css" rel="stylesheet" />
      <link href="../Content/style.css" rel="stylesheet" />
      <style>
          #cityGridView th {
              background-color: #00ffff;
              text-align: center;
              font-size: 18px;
          }
            label.error {
                color: red;
                font-style: italic;
            }
            #errmsg {
                color: red;
                font-style: italic;
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
					<img class="menu-img" src="../images/icon_home.png" alt="home" style="box-sizing:content-box;"/>
					<p class="text">Home</p>
				</a>
			</div>
			<div class="menuContainer" id="service">
				<a href="/UI/CountryEntry.aspx">
					<img class="menu-img" src="../images/customer-service-icon.png" alt="Country Entry" style="box-sizing:content-box;"/>
					<p class="text">Country Entry</p>
				</a>
			</div>
			<div class="menuContainer" id="product">
				<a href="/UI/CityEntry.aspx">
					<img class="menu-img" src="../images/StorageIcon01.png" alt="City Entry" style="box-sizing:content-box;"/>
					<p class="text">City Entry</p>
				</a>
			</div>
			<div class="menuContainer" id="gallery">
				<a href="/UI/CityView.aspx">
					<img class="menu-img" src="../images/icon-gallery.png" alt="City View" style="box-sizing:content-box;"/>
					<p class="text">City View</p>
				</a>
			</div>
			<div class="menuContainer" id="contact">
				<a href="/UI/CountryView.aspx">
					<img class="menu-img" src="../images/ICON_contact.png" alt="Country View" style="box-sizing:content-box;"/>
					<p class="text">Country View</p>
				</a>
			</div>         
        </nav>
    </div>

      <div class="container-fluid">
          <div class="message">
            <asp:Label ID="messageLabel" runat="server" CssClass="label-danger"></asp:Label>
        </div>
         <div class="panel panel-default" style="margin-top:60px;">
              <div class="panel-heading">
                <h3 class="panel-title">City Entry</h3>
              </div>
              <div class="panel-body">
                <form id="CityEntryForm" runat="server" class="form-horizontal"> 
                        <div class="form-group">
                            <label for="nameTextBox" class="col-sm-2 control-label">Name</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="nameTextBox" name="nameTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="countryAboutLabel" class="col-sm-2 control-label">About</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="aboutCkEditor" name="aboutCkEditor" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="dwellersTextBox" class="col-sm-2 control-label">No. of dwellers</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="dwellersTextBox" name="dwellersTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                <span id="errmsg"></span>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="locationTextBox" class="col-sm-2 control-label">Location</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="locationTextBox" name="locationTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="weatherTextBox" class="col-sm-2 control-label">Weather</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="weatherTextBox" name="weatherTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="countryDropDownList" class="col-sm-2 control-label">Country</label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="countryDropDownList" name="countryDropDownList" runat="server" CssClass="form-control input-sm">
                                </asp:DropDownList>
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                              <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" CssClass="btn btn-primary"/> 
                              <a href="/UI/Index.aspx" class="btn btn-primary">Cancel</a>
                            </div>
                         </div>  
                  </div><!--panel-body-->
                </div><!--end of panel-->   
                    <asp:GridView ID="cityGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover">
					    <Columns>
						    <asp:TemplateField HeaderText="S.No">
						       <ItemTemplate>
						      <%# Container.DataItemIndex + 1%>
						       </ItemTemplate>
						       </asp:TemplateField>

						    <asp:TemplateField HeaderText="Name">
							    <ItemTemplate>
								    <%# Eval("CityName") %>
							    </ItemTemplate>
						    </asp:TemplateField>

						    <asp:TemplateField HeaderText="No Of Dwellers">
							    <ItemTemplate>
								    <%# Eval("NoOfDwellers") %>
							    </ItemTemplate>
						    </asp:TemplateField>

						    <asp:TemplateField HeaderText="Country">
							    <ItemTemplate>
								    <%# Eval("CountryName") %>
							    </ItemTemplate>
						    </asp:TemplateField>
					    </Columns>
				    </asp:GridView>        
              </form>            
    </div><!--End of container-fluid-->
	<footer class="footer">
      <div class="container-fluid">
        <p class="text-muted">Design & Develop By Null Point Team,@All Right Reserved By BITM</p>
      </div>
    </footer>
	  <script src="../Scripts/jquery-1.12.3.min.js"></script>
      <script src="../Scripts/bootstrap.min.js"></script>
      <script src="../Scripts/jquery.validate.js"></script>
      <script src="../Scripts/ckeditor/ckeditor.js"></script>
      <script src="../Scripts/ckeditor/adapters/jquery.js"></script>
      <script>
          $(document).ready(function () {

              //add ckeditor plugin
              $(function () {
                  CKEDITOR.replace('<%=aboutCkEditor.ClientID %>',
                    { filebrowserImageUploadUrl: '/Upload.ashx' }); //path to “Upload.ashx”
              });

             //add select one into dropdown list
             $("#countryDropDownList").prepend('<option Value="0" selected>Select One</option>');

             $("#CityEntryForm").validate({
                 rules: {
                     nameTextBox: "required",                     
                     dwellersTextBox: { required:true },
                     locationTextBox: "required",
                     weatherTextBox: "required",
                     countryDropDownList: {
                         required:true
                     }
                 },
             messages: {
                 nameTextBox: "please provide city name!!",
                 dwellersTextBox: {
                     required:"please provide number of dwellers!!"
                 },
                 locationTextBox: "please provide location!!",
                 weatherTextBox: "please provide weather!!"
             }
             });
             $("#dwellersTextBox").keypress(function (e) {
                 
                 if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {                     
                     $("#errmsg").html("Digits Only").show().fadeOut("slow");
                     return false;
                 }
             });            
         });        
     </script>
  </body>
</html>
