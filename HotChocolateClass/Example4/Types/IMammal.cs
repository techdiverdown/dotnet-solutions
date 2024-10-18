namespace Example4.Types;

// a union is a set of type, in this case,
// the union is a set of types that implement the IMammal interface
// this is useful when you want to return a type that could be one of several types
// after you define this, then add this interface to the types that you want to be part of the union
// in this case, Dog and Cat implement IMammal
[UnionType("Mammal")]
public interface IMammal
{
    string Name { get; set; }
}