namespace CompositePattern;

public class Component
{
    public virtual string Operation()                 => throw new NotImplementedException();
    public virtual void   Add(Component    component) => throw new NotImplementedException();
    public virtual void   Remove(Component component) => throw new NotImplementedException();
    public virtual bool   IsComposite()               => true;
}