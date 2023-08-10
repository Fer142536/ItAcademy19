namespace Laboratorio5;
using System.Drawing;

class CirculoColoridoPreenchido : CirculoColorido
{
    private Color corAdicional;

     public Color CorAdicional
    {
        get { return corAdicional; }
        set { corAdicional = value; }
    }

    public CirculoColoridoPreenchido(): base()
    {
        corAdicional = Color.Red; 
    }

    public CirculoColoridoPreenchido(double x, double y, double r, string c, Color cAdi): base(x, y, r,c)
    {   
        corAdicional = cAdi;
    }

    public override string ToString()
{
    return base.ToString() + " Cor Adicional=" + corAdicional.ToKnownColor();

}
}