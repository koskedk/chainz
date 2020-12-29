import { Body, Controller, Get, Post } from '@nestjs/common';
import { AppService } from './app.service';
import { Product } from './models/product';

@Controller()
export class AppController {
  constructor(private readonly appService: AppService) {}

  @Get()
  getHello(): Product[] {
    return this.appService.getProducts();
  }

  @Post()
  saveProduct(@Body() product: Product): string {
    this.appService.addProduct(product);
    return product.name;
  }
}
