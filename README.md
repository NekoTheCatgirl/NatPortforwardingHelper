# NatPortforwardingHelper
A simple app designed to help the less technically inclined people setup port forwarding. Only works on routers with UPnP support.

# How to use:
  1. Input the public and private port, this will pick what port someone outside your network will connect to, public -> private
  2. Write a sensible name for the mapping.
  3. Select if you want it to be a Tcp or Udp style mapping.
  4. Press the "Attempt to open port" button.
 
# A bit of info:
  * The app can not overwrite any existing mappings as of now.
  * The app will not work when the port mapping table on your router is full.
  * The app will not work if your router does not support UPnP or if its disabled in your router configuration.
