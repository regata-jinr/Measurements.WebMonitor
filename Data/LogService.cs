using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitorBlazor.Data
{
  public class LogService
  {
    public Task<Log[]> GetLogsAsync(DateTime startDate)
    {
      var lc = new LogContext();
      return Task.FromResult(lc.logs.Where(log => log.date_time.Date == startDate.Date).OrderByDescending(log => log.date_time).ToArray());
    }
  }
}
