import { CommonModule } from '@angular/common';  // Contains *ngFor, *ngIf, etc.import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Component } from '@angular/core';
import { WishItem } from '../shared/models/wishItem';

// "decorator"
@Component({
  selector: 'app-root', 
  standalone: true,
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  wishList = [
    new WishItem("Learn Angular"),
    new WishItem("Do a flip"),
    new WishItem("Eat pastrami"),
    new WishItem("Drive Fast", true),
    new WishItem("Play Undertale", true),
    new WishItem("Die young", true),
    new WishItem("Dinner with myself")
  ]


  title = 'Wishlist';
}
