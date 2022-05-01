class ContextImpl : Common.Context {
    private readonly int _value;
    public ContextImpl(int value) {
        _value = value;
    }

    public int Value => _value;
}
