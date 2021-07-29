import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  photos = [
    {
      url: 'https://pm1.narvii.com/6701/29aba39736d91e0173afb3a1c348900e585a2f43_hq.jpg',
      description: 'Esquilo'
    },
    {
      url: 'https://pbs.twimg.com/profile_images/832340791913750529/wwEO11b_.jpg',
      description: 'Esquilo-Dobrador-Terra'
    }
  ];
}
