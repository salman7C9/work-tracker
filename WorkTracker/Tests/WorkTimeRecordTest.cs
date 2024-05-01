using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build;

namespace Tests
{
    public class WorkTimeRecordTest
    {

        [Fact]
        public void GetDuration_WithoutEnd_ReturnsCurrentWorkTime()
        {
            // arrange
            var start = DateTime.Now.AddHours(-8);
            var workRecord = new WorkTimeRecord(start);

            // act
            var result = workRecord.GetDuration();

            // assert
            Assert.Equal(8, result.Hours);
        }

        [Fact]
        public void GetDuration_WithEnd_ReturnsEndStartSpan()
        {
            // arrange
            var end = DateTime.Now;
            var start = end.AddHours(-9).AddMinutes(-30);
            var workRecord = new WorkTimeRecord(start, end);

            // act
            var result = workRecord.GetDuration();

            // assert
            Assert.Equal(9 * 60 + 30, result.TotalMinutes);
        }
    }
}
