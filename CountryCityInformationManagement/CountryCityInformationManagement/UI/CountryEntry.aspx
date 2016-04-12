<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" Inherits="CountryCityInformationManagement.CountryEntry" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <title>City Country Information Management | Country Entry</title>
      <link href="../Content/bootstrap.css" rel="stylesheet" />
      <link href="../Content/sticky-footer-navbar.css" rel="stylesheet" />
      <link href="../Content/style.css" rel="stylesheet" />
      <style>
          #countryGridView th{ 
                background-color:#00ffff;
                text-align:center;
                font-size:18px;
          }
           label.error {
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
			</div><!--home-->
			<div class="menuContainer" id="service">
				<a href="/UI/CountryEntry.aspx">
					<img class="menu-img" src="../images/customer-service-icon.png" alt="Country Entry" style="box-sizing:content-box;"/>
					<p class="text">Country Entry</p>
				</a>
			</div><!--country entry-->
			<div class="menuContainer" id="product">
				<a href="/UI/CityEntry.aspx">
					<img class="menu-img" src="../images/StorageIcon01.png" alt="City Entry" style="box-sizing:content-box;"/>
					<p class="text">City Entry</p>
				</a>
			</div><!--city entry-->
			<div class="menuContainer" id="gallery">
				<a href="/UI/CityView.aspx">
					<img class="menu-img" src="../images/icon-gallery.png" alt="City View" style="box-sizing:content-box;"/>
					<p class="text">City View</p>
				</a>
			</div><!--city view-->
			<div class="menuContainer" id="contact">
				<a href="/UI/CountryView.aspx">
					<img class="menu-img" src="../images/ICON_contact.png" alt="Country View" style="box-sizing:content-box;"/>
					<p class="text">Country View</p>
				</a>
			</div><!--country view-->         
        </nav>
    </div>

      <div class="container-fluid">
          <div class="message">
            <asp:Label ID="messageLabel" runat="server" CssClass="label-danger"></asp:Label>
          </div>
         <div class="panel panel-default" style="margin-top:60px;">
              <div class="panel-heading">
                <h3 class="panel-title">Country Entry</h3>
              </div>
              <div class="panel-body">
                <form id="CountryEntryForm" runat="server" class="form-horizontal"> 
                        <div class="form-group">
                            <label for="countryNameLabel" class="col-sm-2 control-label">Name</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="countryNameTextBox" name="countryNameTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="countryAboutLabel" class="col-sm-2 control-label">About</label>
                            <div class="col-sm-8">
                                <CKEditor:CKEditorControl ID="countryAboutCkEditor" name="countryAboutCkEditor" BasePath="/Scripts/ckeditor/" runat="server" CssClass="form-control"></CKEditor:CKEditorControl>
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
                        <asp:GridView ID="countryGridView" AutoGenerateColumns="false" runat="server" CssClass="table table-bordered table-hover">
                             <Columns>
                                <asp:TemplateField HeaderText="SL#">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Name">
                                    <ItemTemplate>
                                        <%# Eval("CountryName") %>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="About">
                                    <ItemTemplate>
                                        <%# Eval("AboutCountry") %>
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
      <script>
           $(document).ready(function () {
               $("#CountryEntryForm").validate({
                   rules: {
                       countryNameTextBox: {
                           required:true
                       }
                      
                   },
                   messages: {
                       countryNameTextBox: {
                           required:"please provide country name"
                       }
                   }
               });
              
           });
     </script>
  </body>
</html>
