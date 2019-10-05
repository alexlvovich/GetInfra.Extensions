using FluentAssertions;
using System;
using Xunit;

namespace GetInfra.Extentions.Tests
{
    public class StringExtentionsTests
    {
        [Theory]
        [InlineData("The basic title")]
        [InlineData("I ♥ Dogs")]
        [InlineData("  Déjà Vu!  ")]
        public void Slugify(string str)
        {
            var slug = str.ToSlug();

            slug.Should().NotBeNullOrEmpty();
        }
    }
}
