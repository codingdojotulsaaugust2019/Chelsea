from django.shortcuts import render, redirect
from .models import Order, Product

def index(request):
    context = {
        "all_products": Product.objects.all()
    }
    return render(request, "store/index.html", context)

def checkout(request):
    context = {
        "id": id,
        "all_products": Product.objects.all(),
        "quantity": Order.objects.get(id=id).quantity_ordered,
        "price": Order.objects.get(id=id).price,
        "total_charge": float(quantity) * price,
    }
    return render(request, ("store/checkout.html"), context)

def process_checkout(request):
    all_products = Product.objects.all()
    quantity_from_form = request.POST["quantity"]
    price_from_form = request.POST["price"]
    print("Charging credit card...")
    print("quantity_from_form =", request.POST["quantity"])
    print("price_from_form =", request.POST["price"])
    total = float(quantity_from_form) * price_from_form

    Order.objects.create(quantity_ordered=quantity_from_form, total_price=total)
    id = Order.objects.last().id

    return redirect('/checkout', id)
    
