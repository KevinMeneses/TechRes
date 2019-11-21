<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.master" CodeBehind="Facturacion.aspx.cs" Inherits="TechRestaurant.Facturacion" %>

<asp:Content ContentPlaceHolderID ="cabecera" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Facturación</title>
    <style type="text/css">
      .hiddencol
      {
        display: none;
      }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID ="contenido" runat="server">
    <div class ="col-8 offset-2">
        <div class="card">
            <div class="card-header bg-info text-white" style="text-align:center">FACTURACIÓN</div>
    						
            <div class="card-body">

                <div class="form-group">
                    <div class ="col-12">
		                <div class="row" style="margin-bottom:20px; margin-top:15px">
			                <div class ="col-12">
			                    <asp:GridView ID="gvMesas" runat="server" AutoGenerateColumns="False" CssClass="col-12 table-sm table-info" OnRowCommand="gvMesas_RowCommand">
			                        <Columns>
			                            <asp:BoundField DataField="id" HeaderText="ID" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol"/>
                                        <asp:BoundField DataField="numero_mesa" HeaderText="Mesa"/>
                                        <asp:BoundField DataField="cantidad_sillas" HeaderText="Sillas"/>
                                        <asp:BoundField DataField="nombre" HeaderText="Empleado asignado"/>
                                        <asp:BoundField DataField="id_pedido" HeaderText="Pedido"/>
                                        <asp:TemplateField HeaderText="Ver mesa" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:ImageButton CssClass="btn btn-info btn-sm" BorderColor="White" ButtonType="Image" ImageUrl="https://icon-icons.com/icons2/94/PNG/32/wine_table_16786.png" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
                                            </ItemTemplate>
                                        </asp:TemplateField>			                                    	                  
			                        </Columns>
			                    </asp:GridView>   
			                </div>
			            </div>
			        </div>
	            </div>                                
    
                <div class="form-group">
                    <div class ="col-12">
		                <div class="row" style="margin-top:15px">
                            <div class ="col-5">  
                                <label for="ddlEmpleado">Empleado</label>
                                <asp:DropDownList class="form-control" id="ddlEmpleado" runat="server"></asp:DropDownList>                                             
                            </div>

                            <div class ="col-2">                           
                                <label for="ddlMesa">Mesa</label> 
                                <asp:DropDownList class="form-control" id="ddlMesa" runat="server"></asp:DropDownList>
                            </div>

                            <div class ="col-2" style="margin-right:20px">
                                <asp:Button id="btQuitar" style="position:absolute; bottom:0" class="btn btn-danger btn-block" OnClick="btQuitar_Click" type="button" runat="server" Text="Quitar" />
                            </div>
                                            
                            <div class ="col-2">
                                <asp:Button id="btAsignar" style="position:absolute; bottom:0" class="btn btn-success btn-block" OnClick="btAsignar_Click" type="button" runat="server" Text="Asignar" />
                            </div>  

                            <div class="row" style="margin-top:20px">
                                <div class ="col-12">
                                    <asp:Label ID="lbError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                    <asp:Label ID="lbMensaje" runat="server" ForeColor="Green" Text=""></asp:Label>
                                </div>
                            </div>
                        </div>

                                    

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="scripts" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script> 
</asp:Content>
