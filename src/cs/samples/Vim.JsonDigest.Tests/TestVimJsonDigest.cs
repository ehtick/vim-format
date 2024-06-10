﻿using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;
using Vim.Util;
using Vim.Util.Logging;

namespace Vim.JsonDigest.Tests
{
    [TestFixture]
    public static class TestVimJsonDigest
    {
        [Test]
        public static async Task Test_VimJsonDigest()
        {
            var logger = new StdLogger();

            // Download the given VIM file.
            var url = "https://vimdevelopment01storage.blob.core.windows.net/samples/RoomTest.vim";
            
            using var memoryStream = new MemoryStream();
            using (var _ = logger.LogDuration($"Downloading VIM file from: {url}"))
            {
                var progress = new SynchronousProgress<double>(p => 
                    logger.LogInformation($"Downloading {p:P}"));

                var bytesDownloaded = await Http.DownloadAsync(url, memoryStream, progress, bufferSize: Http.DefaultDownloadBufferSize * 10);
                logger.LogInformation($"Downloaded {bytesDownloaded} bytes");
            }

            // Create a VIM json digest from the memory stream.
            var vimJsonDigest = new VimJsonDigest(memoryStream);
            var jsonContent = vimJsonDigest.ToJson();

            // Assert the contained collections are not empty.
            Assert.IsNotEmpty(vimJsonDigest.RoomInfoCollection, "Room info collection is empty.");
            Assert.IsNotEmpty(vimJsonDigest.MaterialInfoCollection, "Material info collection is empty.");
            Assert.IsNotEmpty(vimJsonDigest.AreaInfoCollection, "Area info collection is empty.");

            // Assert that we can read the json file path and reconstruct the VIM json digest.
            var readVimJsonDigest = VimJsonDigest.FromJson(jsonContent);
            Assert.AreEqual(vimJsonDigest.RoomInfoCollection.Count, readVimJsonDigest.RoomInfoCollection.Count);
            Assert.AreEqual(vimJsonDigest.AreaInfoCollection.Count, readVimJsonDigest.AreaInfoCollection.Count);
            Assert.AreEqual(vimJsonDigest.MaterialInfoCollection.Count, readVimJsonDigest.MaterialInfoCollection.Count);
        }
    }
}
