﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluginGenerator;
using System.IO;
using Tests.Common;

namespace PluginGeneratorTests
{
    [TestClass]
    public class JarBuilderTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void JarBuilder_Layout()
        {
            // Arrange
            TestLogger logger = new TestLogger();
            string inputsDir = TestUtils.CreateTestDirectory(this.TestContext, "inputs");
            string rootTempDir = TestUtils.CreateTestDirectory(this.TestContext, "temp");
            string contentDir = Path.Combine(rootTempDir, JarBuilder.JAR_CONTENT_DIRECTORY_NAME);

            string file1 = TestUtils.CreateTextFile("file1.txt", inputsDir, "file1 content");
            string file2 = TestUtils.CreateTextFile("file2.txt", inputsDir, "file2 content");
            string file3 = TestUtils.CreateTextFile("file3.txt", inputsDir, "file3 content");

            // Act
            JarBuilder builder = new JarBuilder(logger, new MockJdkWrapper());
            builder.SetManifestPropety("prop1", "prop1 value");
            builder.SetManifestPropety("prop2", "prop2 value");
            builder.SetManifestPropety("prop3", "prop3 value");

            builder.AddFile(file1, null);
            builder.AddFile(file2, "myorg\\myapp\\f2.txt");
            builder.AddFile(file3, "resources\\f3.txt");

            builder.LayoutFiles(rootTempDir);

            // Assert
            string content = TestUtils.AssertFileExists(JdkWrapper.MANIFEST_FILE_NAME, rootTempDir);
            AssertManifestPropertyExists(content, "prop1", "prop1 value");
            AssertManifestPropertyExists(content, "prop2", "prop2 value");
            AssertManifestPropertyExists(content, "prop3", "prop3 value");

            content = TestUtils.AssertFileExists("file1.txt", contentDir);
            Assert.AreEqual("file1 content", content, "Unexpected file content");

            content = TestUtils.AssertFileExists("myorg\\myapp\\f2.txt", contentDir);
            Assert.AreEqual("file2 content", content, "Unexpected file content");

            content = TestUtils.AssertFileExists("resources\\f3.txt", contentDir);
            Assert.AreEqual("file3 content", content, "Unexpected file content");
        }


        [TestMethod]
        public void JarBuilder_Build()
        {
            // Arrange
            IJdkWrapper jdkWrapper = new JdkWrapper();

            TestLogger logger = new TestLogger();
            string inputsDir = TestUtils.CreateTestDirectory(this.TestContext, "in");
            string outputsDir = TestUtils.CreateTestDirectory(this.TestContext, "out");

            string file1 = TestUtils.CreateTextFile("file1.txt", inputsDir, "file1 content");
            string file2 = TestUtils.CreateTextFile("file2.txt", inputsDir, "file2 content");

            // Act
            JarBuilder builder = new JarBuilder(logger, jdkWrapper);
            builder.SetManifestPropety("prop1", "prop1 value");

            builder.AddFile(file1, null);
            builder.AddFile(file2, "myorg\\myapp\\f2.txt");

            string finalJarPath = Path.Combine(outputsDir, "newJar.jar");
            bool success = builder.Build(finalJarPath);

            // Assert
            Assert.IsTrue(success, "Failed to build the jar file");
            TestUtils.AssertFileExists(finalJarPath);

            Assert.Inconclusive("TODO: check the jar contents");
        }

        private static void AssertManifestPropertyExists(string content, string key, string value)
        {
            string expected = key + ": " + value;
            Assert.IsTrue(content.Contains(expected), "Setting missing from manifest: {0}", expected);
        }
    }
}