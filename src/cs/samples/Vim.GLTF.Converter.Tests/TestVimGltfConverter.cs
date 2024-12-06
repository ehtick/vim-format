using NUnit.Framework;
using System.IO;
using Vim.Util.Tests;

namespace Vim.Gltf.Converter.Tests;

[TestFixture]
public static class TestVimGltfConverter
{
    [Test]
    public static void VimGltfConverterWritesVimFile()
    {
        var ctx = new CallerTestContext();
        var dir = ctx.PrepareDirectory();

        var vimFilePath = Path.Combine(dir, "Fox.glb.vim");
        var gltfFilePath = Path.Combine(VimFormatRepoPaths.DataDir, "gltf-samples", "Fox.glb");
        Assert.IsTrue(File.Exists(gltfFilePath), $"Input GLTF file not found: {gltfFilePath}");

        var gltfToVimStore = new GltfToVimStore();
        gltfToVimStore.Convert(gltfFilePath, vimFilePath);

        Assert.IsTrue(File.Exists(vimFilePath), $"VIM File not found: {vimFilePath}");
    }
}
