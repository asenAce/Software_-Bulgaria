<?php
  require_once 'core/init.php';
  include 'includes/head.php';
  include 'includes/navigation.php';
  include 'includes/headerfull.php';

$sql = "SELECT * FROM products WHERE featured = 1";
$featured = $db->query($sql);
  ?>


<!--remove the spaces and center the products-->
  <div class="col-md-2"></div>

<!--main content of featured products-->
  <div class="col-md-8">
    <div class="row">
      <h2 class="text-center">Featured Products</h2>
      <?php while($product = mysqli_fetch_assoc($featured)) : ?>
      <div class="col-md-3 text-center">
        <h4><?= $product['title']; ?></h4>
        <img src="<?=$product['image']; ?>" alt="<?=$product['title']; ?>" id="images"/>
        <p class="list-price text-danger">List Price: <s>$<?=$product['list_price']; ?></s></p>
        <p class="price">Our Price: $<?=$product['price']; ?></p>
        <button type="button" class="btn btn-sm btn-success" onclick="detailsmodal(<?= $product['id']; ?>)">Details</button>
      </div>
    <?php endwhile; ?>
  </div>
 <div class="col-md-2"></div>
</div><br><br>
<?php
    include 'includes/footer.php';
 ?>
<!--end of details modal-->
</body>
</html>
