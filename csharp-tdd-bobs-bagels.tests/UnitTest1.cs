using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void addOneBagel_1()
    {
        Core core = new Core();
        Assert.True(core.addBagle(Core.BagleType.PLAINBAGEL));
    }

    [Test]
    public void addOneBagel_2()
    {
        Core core = new Core();
        core.addBagle(Core.BagleType.PLAINBAGEL);
        Assert.True(core.addBagle(Core.BagleType.PLAINBAGEL));
    }

    [Test]
    public void removeOneBagel_1()
    {
        Core core = new Core();
        core.addBagle(Core.BagleType.PLAINBAGEL);
        Assert.True(core.removeBagle(Core.BagleType.PLAINBAGEL));
    }

    [Test]
    public void removeOneBagel_2()
    {
        Core core = new Core();
        Assert.False(core.removeBagle(Core.BagleType.PLAINBAGEL));
    }

    [Test]
    public void assertCurrentSize_1()
    {
        Core core = new Core();
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        Assert.That(core.getCurrentBasketSize() == 5);
    }

    [Test]
    public void assertCurrentSize_2()
    {
        Core core = new Core();
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        Assert.False(core.getCurrentBasketSize() == 6);
    }

    [Test]
    public void assertCurrentSize_3()
    {
        Core core = new Core();
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.PLAINBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        core.addBagle(Core.BagleType.VICTORSSPECIALBAGEL);
        core.removeBagle(Core.BagleType.PLAINBAGEL);
        Assert.That(core.getCurrentBasketSize() == 4);
    }

    [Test]
    public void assertMaxSize_1()
    {
        Core core = new Core();
        core.setBasketSize(10);
        Assert.That(core.getMaxBasketSize() == 10);
    }


}