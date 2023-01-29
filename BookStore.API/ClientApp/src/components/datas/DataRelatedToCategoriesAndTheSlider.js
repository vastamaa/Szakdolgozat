import { Slider } from "../models/Slider";
import { ImageImporter } from "../helper/ImageImporter";

export const sliders = [
  new Slider(
    1,
    ImageImporter("opening-sale"),
    "OPENING SALE",
    "EVERYTHING 10% OFF",
    "#f5faf5"
  ),
  new Slider(
    2,
    ImageImporter("learn-about-egypt"),
    "LEARN ABOUT EGYPT",
    "BUY TWO GET ANOTHER ONE FREE",
    "#f5faf5"
  ),
  new Slider(
    3,
    ImageImporter("book-of-the-week"),
    "BOOK OF THE WEEK",
    "ABOUT PASSION AND MOTIVATION",
    "#f5faf5"
  ),
];

export const categories2 = [
  {
    id: 1,
    img: ImageImporter("lifestyle"),
    title: "LIFESTYLE",
  },
  {
    id: 2,
    img: ImageImporter("lifestyle"),
    title: "HISTORY",
  },
  {
    id: 3,
    img: ImageImporter("gastronomy"),
    title: "GASTRONOMY",
  },
];
export const categories = [
  {
    id: 1,
    img: ImageImporter("comics"),
    title: "COMICS",
  },
  {
    id: 2,
    img: ImageImporter("children"),
    title: "CHILDREN",
  },
  {
    id: 3,
    img: ImageImporter("literature"),
    title: "LITERATURE",
  },
];

export const showmore = [
  {
    id: 1,
    image: ImageImporter("lifestyle"),
    text: "SHOW MORE",
  },
];
