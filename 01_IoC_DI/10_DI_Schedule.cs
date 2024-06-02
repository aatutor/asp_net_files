class ScheduleManager
{
	public Schedule GetSchedule()
	{
		// Do Something by init schedule...   
	}
}

class ScheduleViewer
{
	private ScheduleManager _scheduleManager = new ScheduleManager();
	public void RenderSchedule()
	{
		Shedule temp = _scheduleManager.GetSchedule();
		// Do Something by render schedule... 
	}
}