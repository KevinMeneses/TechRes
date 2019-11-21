<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.master" CodeBehind="AgregarIngrediente.aspx.cs" Inherits="TechRestaurant.AgregarIngrediente" %>

<asp:Content ContentPlaceHolderID ="cabecera" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar ingrediente</title>
</asp:Content>

<asp:Content ContentPlaceHolderID ="contenido" runat="server">
                <div class ="col-4 offset-4">
                    <div class="card">
                        <div class="card-header bg-info text-white" style="text-align:center">AGREGAR INGREDIENTE</div>
    
                        <div class="card-body">

                        	<div class="form-group" style="margin-bottom:10px; margin-top:15px">
                                <div class ="col-12">
                                    <label for="txIngrediente">Ingrediente</label>
                                </div>     
                                <div class ="col-12">                                         
                                    <asp:TextBox type="text" id="txIngrediente" class="form-control" placeholder="Ingrese el nombre del ingrediente" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group" style="margin-bottom:10px; margin-top:15px">
                                <div class ="col-12">
                                    <label for="txPrecio">Precio</label>
                                </div>     
                                <div class ="col-12">
                                    <asp:TextBox type="text" id="txPrecio" class="form-control" placeholder="Ingrese el precio del ingrediente" runat="server"></asp:TextBox>                             
                                </div>
                            </div>

                            <div class="form-group" style="margin-bottom:40px; margin-top:15px">
                                <div class ="col-12">
                                    <label for="txCantidad">Cantidad</label>
                                </div>     
                                <div class ="col-12">
                                    <asp:TextBox type="text" id="txCantidad" class="form-control" placeholder="Ingrese la cantidad del ingrediente" runat="server"></asp:TextBox>                                   
                                </div>
                            </div>

                            <div class="form-group">
                                <div class ="col-12">
                                    <asp:Button type="submit" id="btAgregar" class="btn btn-info btn-lg btn-block" OnClick="btAgregar_Click" runat="server" Text="Agregar" />                                    
                                </div>               
                            </div>
    
                            <div class="row" style="margin-top:20px">
                                <div class ="col-12">
                                    <asp:Label ID="lbMensaje" runat="server" ForeColor="Green" Text=""></asp:Label>
                                </div>
                            </div>

                            <div class="row" style="margin-top:20px">
                                <div class ="col-12">
                                    <asp:Label ID="lbError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="scripts" runat="server">
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script> 
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" ></script>
</asp:Content>