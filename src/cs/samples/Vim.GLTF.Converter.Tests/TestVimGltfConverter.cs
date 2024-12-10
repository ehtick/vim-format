using NUnit.Framework;
using System.IO;
using Vim.Format.SceneBuilder;
using Vim.Util.Tests;

namespace Vim.Gltf.Converter.Tests;

[TestFixture]
public static class TestVimGltfConverter
{
    [TestCase("Fox.glb")]
    [TestCase("SciFiHelmet.glb")]
    [TestCase("ToyCar.glb")]
    public static void VimGltfConverterWritesVimFile(string gltfFileName)
    {
        var ctx = new CallerTestContext(subDirComponents: gltfFileName);
        var dir = ctx.PrepareDirectory();

        var gltfFilePath = Path.Combine(VimFormatRepoPaths.DataDir, "gltf-samples", gltfFileName);
        var vimFilePath = Path.Combine(dir, Path.ChangeExtension(Path.GetFileName(gltfFilePath), ".vim"));
        
        Assert.IsTrue(File.Exists(gltfFilePath), $"Input GLTF file not found: {gltfFilePath}");

        GltfToVimStore.Convert(gltfFilePath, vimFilePath);

        Assert.IsTrue(File.Exists(vimFilePath), $"VIM File not found: {vimFilePath}");

        var vim = VimScene.LoadVim(vimFilePath);
        vim.Validate();
    }
}
