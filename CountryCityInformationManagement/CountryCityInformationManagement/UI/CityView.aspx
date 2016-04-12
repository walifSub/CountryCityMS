<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityView.aspx.cs" Inherits="CountryCityInformationManagement.UI.ViewCities" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <title>City Country Information Management | Country View</title>
      <link href="../Content/bootstrap.css" rel="stylesheet" />
      <link href="../Content/jquery.dataTables.min.css" rel="stylesheet" />
      <link href="../Content/sticky-footer-navbar.css" rel="stylesheet" />
      <link href="../Content/style.css" rel="stylesheet" />
      <style>
          #cityViewGridView_paginate{
            display: block;
            float: left;
            margin: 20px auto 0;
            position: relative;
            text-align: center;
            width: 80%;
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

      <div class="container-fluid" style="padding-bottom:60px">
          <div class="message">
            <asp:Label ID="messageLabel" runat="server" CssClass="label-danger"></asp:Label>
        </div>
         <div class="panel panel-default" style="margin-top:60px;">
              <div class="panel-heading">
                <h3 class="panel-title">Search Criteria</h3>
              </div>
              <div class="panel-body">
                <form id="CitySearchForm" runat="server" class="form-horizontal"> 
                        <div class="form-group">
                            <label for="countryNameLabel" class="col-sm-2 control-label">
                                <asp:RadioButton ID="cityNameRadioButton" runat="server" Text="  City Name" GroupName="search" Checked="True"/>
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="cityNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="countryNameLabel" class="col-sm-2 control-label">
                                <asp:RadioButton ID="countryNameRadioButton" runat="server" Text="  Country" GroupName="search"/>
                            </label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="countryDropDownList" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div> 
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                              <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" CssClass="btn btn-primary" />
                            </div>
                         </div>  
                  </div><!--panel-body-->
                </div><!--end of panel-->
                <asp:GridView ID="cityViewGridView" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="SL#">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="City Name">
                            <ItemTemplate>
                                <%# Eval("CityName") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="About">
                            <ItemTemplate>
                                <%# Eval("About") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="No Of dwellers">
                            <ItemTemplate>
                                <%# Eval("NoOfDwellers") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Location">
                            <ItemTemplate>
                                <%# Eval("Location") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Weather">
                            <ItemTemplate>
                                <%# Eval("Weather") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Country">
                            <ItemTemplate>
                                <%# Eval("CountryName") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="About Country">
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
    <script src="../Scripts/jquery.dataTables.min.js"></script>
    <script>

        $(document).ready(function () {
            $('#cityViewGridView').DataTable({
                "bFilter": false
            });

            //add select one into dropdown list
            $("#countryDropDownList").prepend('<option Value="0" selected>Select One</option>');

            //Radio button enable / disable
            $("#countryDropDownList").attr("disabled", "disabled");
            $("input[name=search]:radio").change(function () {

                var citySelect = $("#cityNameRadioButton").is(":checked");
                var countrySelect = $("#countryNameRadioButton").is(":checked");

                if (citySelect) {
                    $("#countryNameRadioButton").removeAttr("checked");
                    $("#cityNameTextBox").removeAttr("disabled");
                    $("#countryDropDownList").attr("disabled", "disabled");
                }
                else if (countrySelect) {
                    $("#cityNameRadioButton").removeAttr("checked");
                    $("#cityNameTextBox").attr("disabled", "disabled");
                    $("#countryDropDownList").removeAttr("disabled");
                }

            }); 


        });
    </script> 
      
  </body>
</html>
