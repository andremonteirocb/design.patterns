namespace Fundamentos.Design.Patterns.Comportamental.ChainOfResponsability
{
    public class DescontoFGTSlHandler : AbstractHandler
    {
        public override string Handle(object request)
        {
            if (request.ToString() == "FGTS")
            {
                return $"FGTS: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
