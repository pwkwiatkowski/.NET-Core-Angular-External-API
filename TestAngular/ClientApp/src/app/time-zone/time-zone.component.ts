import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { model } from '../../../Models/HttpClientModel';


@Component({
  selector: 'app-time-zone',
  templateUrl: './time-zone.component.html'
})
export class TimeZoneComponent {
  public timeZoneData: TimeZoneData;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<TimeZoneData>(baseUrl + 'timezone').subscribe(result => {
      this.timeZoneData = result;
    }, error => console.error(error));
  }
}

interface TimeZoneData {
  abbreviation: string;
  client_ip: string;
  datetime: string;
  day_of_week: number;
  day_of_year: number;
  dst: boolean;
  dst_from: string;
  dst_offset: number;
  dst_until: string;
  raw_offset: number;
  timezone: string;
  unixtime: number;
  utc_datetime: string;
  utc_offset: string;
  week_number: number;
}
