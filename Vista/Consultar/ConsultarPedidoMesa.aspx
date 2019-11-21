<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarPedidoMesa.aspx.cs" Inherits="TechRestaurant.Principales.ConsultarPedidoMesa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
  	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pedido mesa</title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-light bg-info">
            <b class="navbar-brand" style="color: white;" href="#">TECHRES</b>
        </nav>

        <div class="row" style="margin-top:40px">
                <div class ="col-4 offset-4">
                    <div class="card">
                        <div class="card-header bg-info text-white" style="text-align:center">PEDIDO MESA #</div>
    						
                        <div class="card-body">

                        	<div class="form-group">
                                <div class ="col-12">
		                            <div class="row" style="margin-bottom:5px">
			                            <div class ="col-12">
			                                <asp:GridView ID="gvMesas" runat="server" AutoGenerateColumns="False" CssClass="col-12 table-sm table-info">
			                                    <Columns>
			                                    	<asp:BoundField DataField="nombre" HeaderText="Plato"/>           
			                                    </Columns>
			                                </asp:GridView>   
			                            </div>
			                        </div>
			                    </div>
	                        </div>  

                            <div class="form-group" style="margin-bottom:40px; margin-top:15px">
                                <div class ="col-12">
                                    <label for="lbTotal">Total</label>
                                </div>     
                                <div class ="col-12">
                                    <label class="form-control"></label>
                                </div>             
                            </div>

                            <div class="form-group">
                                <div class ="col-12">
                                    <button type="submit" id="btAgregar" class="btn btn-info btn-lg btn-block">Agregar o cambiar</button>
                                    <button type="submit" id="btLiberar" class="btn btn-danger btn-lg btn-block">Liberar mesa</button>
                                </div>               
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script> 
    </form>
</body>
</html>
