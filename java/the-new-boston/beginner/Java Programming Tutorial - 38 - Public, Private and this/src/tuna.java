
public class tuna {
	private int hour, minute, second; // only methods in here can use private
	
	// public can be used outside of this class
	// this means to use the local ones to the method
	
	public void setTime(int hour, int minute, int second){
		hour = (this.hour >= 0 && this.hour < 24) ? this.hour : 0;
		minute = (this.minute >= 0 && this.minute < 60) ? this.minute : 0;
		second = (this.second >= 0 && this.second < 60) ? this.second : 0;
	}
	
	public String toMilitary(){
		return String.format("%02d:%02d:%02d", hour, minute, second);
	}
	
	public String toString(){
		return String.format("%d:%02d:%02d %s", (hour == 0 || hour == 12) ? 12 : hour%12, minute, second, (hour < 12) ? "AM" : "PM");
	}
}

