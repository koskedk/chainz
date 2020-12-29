import { Injectable } from '@nestjs/common';
import { Product } from './models/product';

@Injectable()
export class AppService {
  products: Product[] = [];
  getProducts(): Product[] {
    return this.products;
  }
  addProduct(product: Product) {
    this.products.push(product);
  }
}
