namespace Fundamentos.Design.Patterns.Comportamental.ChainOfResponsability
{
    public class DescontoICMSHandler : AbstractHandler
    {
        public override string Handle(object request)
        {
            if (request.ToString() == "ICMS")
            {
                return $"ICMS: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
