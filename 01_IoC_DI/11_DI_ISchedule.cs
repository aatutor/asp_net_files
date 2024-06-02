interface IScheduleManager
{
	Schedule GetSchedule();
}

class ScheduleManager : IScheduleManager
{
	public Schedule GetSchedule()
	{
		// Do Something by init schedule...        
	}
}

class ScheduleViewer
{
	private IScheduleManager _scheduleManager;
	public ScheduleViewer(IScheduleManager scheduleManager)
	{
		_scheduleManager = scheduleManager;
	}
	public void RenderSchedule()
	{
		_scheduleManager.GetSchedule();
		// Do Something by render schedule... 
	}
}
