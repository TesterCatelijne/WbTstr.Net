﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FluentAutomation.Tests.Actions
{
    public class PressTypeTests : BaseTest
    {
        public PressTypeTests()
            : base()
        {
            InputsPage.Go();
        }

        [Fact(Skip = "This test doens't work when using a remote webdriver (e.g. BrowserStack).")]
        public void PressType()
        {
            I.Focus(InputsPage.TextControlSelector)
             .Press("{TAB}")
             .Type("wat")
             .Assert.Text("wat").In(InputsPage.TextareaControlSelector);
        }

    }
}
