<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.master" CodeBehind="AgregarPedido.aspx.cs" Inherits="TechRestaurant.AgregarPedido" %>

<asp:Content ContentPlaceHolderID ="cabecera" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar Pedido</title>
    <style type="text/css">
      .hiddencol
      {
        display: none;
      }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID ="contenido" runat="server">
    <div class ="col-6 offset-3">
        <div class="card">
            <div class="card-header bg-info text-white" style="text-align:center">AGREGAR PEDIDO</div>
    
            <div class="card-body">

                <div class="form-group">
                    <div class ="col-12">
		                <div class="row" style="margin-bottom:20px; margin-top:15px">
			                <div class ="col-12">
			                    <asp:GridView ID="gvPedido" runat="server" AutoGenerateColumns="False" CssClass="col-12 table-sm table-info" OnRowCommand="gvPedido_RowCommand">
			                        <Columns>
                                        <asp:BoundField DataField="id" HeaderText="ID plato" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol"/>
                                        <asp:BoundField DataField="nombre" HeaderText="Plato"/>
                                        <asp:BoundField DataField="precio" HeaderText="Precio"/>
                                        <asp:TemplateField HeaderText="Acción" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Button CssClass="btn btn-danger" BorderColor="White" Text="Quitar" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
                                            </ItemTemplate>
                                        </asp:TemplateField>			                                    	                  
			                        </Columns>
			                    </asp:GridView>   
			                </div>
			            </div>
			        </div>
	            </div>

                <div class="form-group" id="fields">        
                    <div class="controls form-group col-12"> 
                        <div role="form">
                            <div class="entry input-group form-row">
                                <div class ="col-6">
                                    <label for="ddlPlatos">Platos</label>
                                    <asp:DropDownList ID="ddlPlatos" class="form-control" OnSelectedIndexChanged="ddlPlatos_SelectedIndexChanged" runat="server" AutoPostBack="True"></asp:DropDownList>                                                
                                </div>
                                <div class ="col-4">    
                                    <label for="lbPrecio">Precio</label> 
                                    <asp:Label class="form-control" id="lbPrecio" runat="server"></asp:Label>
                                </div>
                                <div class ="col-2">
                                    <asp:Button ID="btAgregar" style="position:absolute; bottom:0" class="btn btn-success" type="button" OnClick="btAgregar_Click" runat="server" Text="Agregar" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class ="col-12">                           
                        <label for="ddlMesa">Mesa</label> 
                        <asp:DropDownList class="form-control" id="ddlMesa" runat="server"></asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <div class ="col-12">
                        <label for="txDescripcion">Descripcion</label>
                    </div>
                    <div class ="col-12">
                        <asp:TextBox ID="txDescripcion" class="form-control" runat="server" placeholder="Ingrese la descripción del pedido"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group" style="margin-bottom:40px; margin-top:15px">
                    <div class ="col-12">
                        <label for="lbTotal">Total</label>
                    </div>     
                    <div class ="col-12">
                        <asp:Label ID="lbTotal" class="form-control" runat="server" Text=""></asp:Label>
                    </div>             
                </div>
    
                <div class="form-group">
                    <div class ="col-12">
                        <asp:Button type="submit" id="btGuardar" class="btn btn-info btn-lg btn-block" OnClick="btAsignar_Click" runat="server" Text="Guardar" />
                    </div>               
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
</asp:Content>

<asp:Content ContentPlaceHolderID="scripts" runat="server">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script> 
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</asp:Content>