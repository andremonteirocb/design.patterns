namespace Fundamentos.Design.Patterns.Comportamental.ChainOfResponsability
{
    public class DescontoISSHandler : AbstractHandler
    {
        public override string Handle(object request)
        {
            if ((request as string) == "ISS")
            {
                return $"ISS: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
